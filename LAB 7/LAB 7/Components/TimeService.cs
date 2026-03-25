namespace LAB_7.Components
{
    public class TimeService
    {
        public string getcurrentTime()
        {
            return DateTime.Now.ToString("hh:mm:ss tt");
        }
    }
}
