

namespace DO;

[Serializable]
public class DalNotFoundId : Exception {
  

    public DalNotFoundId(string message) : base(message) { }
}
[Serializable]
public class DalIdExist : Exception
{
    public DalIdExist(string message) : base(message) { }

}

public class DalProductIdExist : Exception
{
    public DalProductIdExist(string message) : base(message) { }

}
