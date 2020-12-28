using System;
namespace FormTyeplovoz
{

    public class DepotOverflowException : Exception
    {
        public DepotOverflowException() : base("В депо нет свободных мест")
        { }
    }
}