using System;

namespace Emilia.Variables
{
    public interface IReadOnlyVariable
    {
        Type type { get; }
        object GetValue();
    }
}