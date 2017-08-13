namespace PassGenWithCS
{
    class Tmp : Encrypt
    {
        public Tmp(string code) : base(code)
        {
        }

        public override string EnPass()
        {
           
            return pass;
        }

        public override string DePass()
        {
            
            return pass;
        }
    }
}
