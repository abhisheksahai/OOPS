namespace OOPS
{
    interface IStudent
    {
        public string GetTime()
        {
            var str = System.DateTime.Now.ToString("yyyy-MM-dd");
            return str;
        }

        string GreetingsMessage();
    }
}
