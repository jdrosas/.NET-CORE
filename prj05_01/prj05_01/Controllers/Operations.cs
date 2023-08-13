namespace prj05_01.Controllers
{
    public class Operations
    {
        public int Square(int i)
        {
            checked
            {
                return i * i;
            }
        }
    }
}
