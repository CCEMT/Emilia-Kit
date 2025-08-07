@echo off
chcp 65001 >nul
setlocal enabledelayedexpansion

echo ====================================================
echo MakeAllPublic 批量处理工具
echo ====================================================
echo.

REM 检查工具是否存在
if not exist "MakeAllPublic\bin\Release\net8.0-windows\MakeAllPublic.exe" (
    echo ❌ 错误: 找不到 MakeAllPublic.exe
    echo 请先运行: dotnet build --configuration Release
    pause
    exit /b 1
)

set TOOL_PATH=MakeAllPublic\bin\Release\net8.0-windows\MakeAllPublic.exe

REM 获取输入和输出文件夹
if "%~1"=="" (
    echo 请拖拽输入文件夹到此批处理文件上，或者手动输入路径
    echo.
    set /p INPUT_FOLDER="输入文件夹路径: "
) else (
    set INPUT_FOLDER=%~1
)

REM 移除路径两边的引号
set INPUT_FOLDER=%INPUT_FOLDER:"=%

REM 检查输入文件夹是否存在
if not exist "!INPUT_FOLDER!" (
    echo ❌ 错误: 输入文件夹不存在: !INPUT_FOLDER!
    pause
    exit /b 1
)

REM 生成输出文件夹路径
set OUTPUT_FOLDER=!INPUT_FOLDER!_public

REM 如果输出文件夹已存在，询问是否继续
if exist "!OUTPUT_FOLDER!" (
    echo ⚠️  输出文件夹已存在: !OUTPUT_FOLDER!
    choice /C YN /M "是否继续(Y/N)"
    if !errorlevel!==2 (
        echo 已取消操作
        pause
        exit /b 0
    )
) else (
    echo 📁 创建输出文件夹: !OUTPUT_FOLDER!
    mkdir "!OUTPUT_FOLDER!"
)

echo.
echo 📂 输入文件夹: !INPUT_FOLDER!
echo 📂 输出文件夹: !OUTPUT_FOLDER!
echo.

REM 计算DLL文件数量
set /a DLL_COUNT=0
for %%f in ("!INPUT_FOLDER!\*.dll") do (
    set /a DLL_COUNT+=1
)

if !DLL_COUNT!==0 (
    echo ❌ 在输入文件夹中未找到任何 .dll 文件
    pause
    exit /b 1
)

echo 🔍 找到 !DLL_COUNT! 个 DLL 文件
echo.
echo 开始处理...
echo =====================================

set /a PROCESSED_COUNT=0
set /a SUCCESS_COUNT=0
set /a ERROR_COUNT=0

REM 处理每个DLL文件
for %%f in ("!INPUT_FOLDER!\*.dll") do (
    set /a PROCESSED_COUNT+=1
    set INPUT_FILE=%%f
    set FILENAME=%%~nf
    set OUTPUT_FILE=!OUTPUT_FOLDER!\!FILENAME!.dll
    
    echo.
    echo [!PROCESSED_COUNT!/!DLL_COUNT!] 正在处理: !FILENAME!.dll
    echo ---------------------------------------
    
    REM 调用工具处理文件
    "!TOOL_PATH!" "!INPUT_FILE!" "!OUTPUT_FILE!"
    
    REM 检查是否成功生成输出文件
    if exist "!OUTPUT_FILE!" (
        set /a SUCCESS_COUNT+=1
        echo ✅ 成功: !FILENAME!.dll
        
        REM 复制对应的XML文档文件（如果存在）
        set XML_INPUT=!INPUT_FOLDER!\!FILENAME!.xml
        set XML_OUTPUT=!OUTPUT_FOLDER!\!FILENAME!.xml
        if exist "!XML_INPUT!" (
            copy "!XML_INPUT!" "!XML_OUTPUT!" >nul 2>&1
            if exist "!XML_OUTPUT!" (
                echo 📄 已复制 XML 文档文件
            )
        )
        
        REM 复制对应的PDB文件（如果存在）
        set PDB_INPUT=!INPUT_FOLDER!\!FILENAME!.pdb
        set PDB_OUTPUT=!OUTPUT_FOLDER!\!FILENAME!.pdb
        if exist "!PDB_INPUT!" (
            copy "!PDB_INPUT!" "!PDB_OUTPUT!" >nul 2>&1
            if exist "!PDB_OUTPUT!" (
                echo 🔍 已复制 PDB 调试文件
            )
        )
    ) else (
        set /a ERROR_COUNT+=1
        echo ❌ 失败: !FILENAME!.dll
    )
)

echo.
echo =====================================
echo 🎉 批量处理完成！
echo =====================================
echo 📊 处理统计:
echo   • 总文件数: !DLL_COUNT!
echo   • 成功处理: !SUCCESS_COUNT!
echo   • 处理失败: !ERROR_COUNT!
echo.
echo 📂 输出文件夹: !OUTPUT_FOLDER!

REM 如果有成功的文件，询问是否打开输出文件夹
if !SUCCESS_COUNT! gtr 0 (
    echo.
    choice /C YN /M "是否打开输出文件夹(Y/N)"
    if !errorlevel!==1 (
        explorer "!OUTPUT_FOLDER!"
    )
)

if !ERROR_COUNT! gtr 0 (
    echo.
    echo ⚠️  注意: 有 !ERROR_COUNT! 个文件处理失败
    echo 可能的原因:
    echo   • 文件被其他程序占用
    echo   • 文件不是有效的 .NET 程序集
    echo   • 权限不足
)

echo.
pause 