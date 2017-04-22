namespace BugRosLyn
{
    public class Test
{
    private int _field;

        public void OuterMethod(int outerParam)
        {
            void InnerMethod1()
            {
                void InnerInnerMethod(int innerInnerParam)
                {
                    InnerInnerInnerMethod();
                    
                    bool InnerInnerInnerMethod() {
                        return innerInnerParam != _field;
                    }
                }

                void InnerMethod2()
                {
                    var temp = outerParam;
                }  
        }
    }
}

}
