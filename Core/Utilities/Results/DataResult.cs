namespace Core.Utilities.Results
{
    public class DataResult<T> : Result, IDataResult<T>
    {
        public DataResult(T data, bool success, string message) : base(success,message)
        {

            Data = data;


        }
        public DataResult(T data , bool success):base(success)
        {
            data = data;
        }

        public T Data { get; }



    }
}