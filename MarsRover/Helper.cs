namespace MarsRover
{
    public static class Helper
    {
        public static T GetCharToEnum<T>(string value) where T : Enum => (T)Enum.Parse(typeof(T), value);
    }
}
