
namespace BO;

[Serializable]
public class BlNotFoundId : Exception
{

    public BlNotFoundId(string message) : base(message) { }
    public BlNotFoundId(string message , Exception innerException) : base(message, innerException) { }

}
[Serializable]
public class BlIdExist : Exception
{
    public BlIdExist (string message) : base(message) { }
    public BlIdExist(string message, Exception innerException) : base(message, innerException) { }

}
[Serializable]
public class BlInvalidQuantityException : Exception
{

    public BlInvalidQuantityException(string message) : base(message) { }

    public BlInvalidQuantityException(string message, Exception innerException)
        : base(message, innerException) { }
}

[Serializable]
public class BlOutOfStockException : Exception
{
    public BlOutOfStockException(string message) : base(message) { }
    public BlOutOfStockException(string message, Exception innerException) : base(message, innerException) { }
}

[Serializable]
public class BlProductIdExist : Exception
{
    public BlProductIdExist(string message) : base(message) { }
    public BlProductIdExist(string message, Exception innerException) : base(message, innerException) { }
}
