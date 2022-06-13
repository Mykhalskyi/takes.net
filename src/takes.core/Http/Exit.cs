namespace takes.core.Http
{
    public interface Exit
    {
        public bool Ready();

        public class Never : Exit
        {
            public bool Ready() => false;
        }
    }
}
