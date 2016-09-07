using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seaBass
{
    class Operator
    {
        //this class will work as a main to manage the various forms
        public Operator()
        {
            
        }

        public void decrypt()
        {
            DecryptFrm decrypt = new DecryptFrm();
            decrypt.Show();
        }

        public void encrypt()
        {
            HideMe encrpyt = new HideMe();
            encrpyt.Show();
        }
        public void keyGen()
        {
            KeyGenFrm keyGen = new KeyGenFrm();
            keyGen.Show();
        }

        public void loop()
        {
            Loop loop = new Loop();
            loop.Show();
        }
        
    }
}
