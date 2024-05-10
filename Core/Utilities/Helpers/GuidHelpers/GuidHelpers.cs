namespace Core.Utilities.Helpers.GuidHelpers
{
    public  class GuidHelpers
    {
        public static string CreatGuid()
        {
            return Guid.NewGuid().ToString();
        }
    }
}
