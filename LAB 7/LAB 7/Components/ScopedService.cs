namespace LAB_7.Components
{
    public class ScopedService
    {
        public string sessionid
        {
            get;
        }

        public ScopedService()
        {
            sessionid=Guid.NewGuid().ToString();
        }
    }
}
