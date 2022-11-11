namespace CSharpBootcamp.GecmisDersler
{
    public class Soru1
    {
        static void MainY(string[] names)
        {
            SimpleClass sc = new SimpleClass();
        }
    }

    public class SimpleClass
    {
        SimpleClass sc;
        public SimpleClass()
        {
            sc = new SimpleClass();
        }
    }
    /*
     * Stack overflow.
     * Repeat 19264 times:
     * --------------------------------
     *    at CSharpBootcamp.Program+SimpleClass..ctor()
     * --------------------------------
     *    at CSharpBootcamp.Program.Main(System.String[])
     */
}
