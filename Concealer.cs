using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace seaBass
{
    class Concealer
    {
        public Concealer()
        {


        }


        private void messageIn(String OrginalMessage)
        {

        }

        public string conceal(String message, String key)
        {
            message = message.ToLower();
            key = key.ToLower();

            string newMessage = "";

            List<List<Int32>> keyList = letterDistributionMK2(key);

            List<Char> alphabetList = new List<char>();
            String alphabetString = "abcdefghijklmnopqrstuvwxyz .@0123456789";
            List<List<Int32>> RepeatList = letterDistributionMK2(key);

            // For loop populates alphabetList from the alphabetList String
            for (int c = 0; c < alphabetString.Count(); c++)
            {
                char temp = alphabetString.ElementAt(c);
                alphabetList.Add(temp);
            }


           
            bool other = false;
            for (int b = 0; b < message.Count(); b++)
            {


                char temp = message.ElementAt(b);
                
                for (int bb = 0; bb < alphabetList.Count(); bb++)
                {
                    if (temp == alphabetList.ElementAt(bb))
                    {
                       
                        //block for manging both lists might be inside wrong loop
                        int keyListCount = keyList.ElementAt(bb).Count();
                        int repeatListCount = RepeatList.ElementAt(bb).Count();
                        //in case the key has to reuse indexes
                        //  throwing error
                        if (keyListCount == 1)
                        {
                            for (int kk=0; kk < RepeatList.ElementAt(bb).Count();  kk++)
                            {
                                keyList.ElementAt(bb).Add(RepeatList.ElementAt(bb).ElementAt(kk));
                            }
                        }
            
                        if (keyList.ElementAt(bb).Count() == 0)
                        {
                            keyList.ElementAt(bb).Add('*');
                           
                        }
                        Random r = new Random();
                        int index = r.Next(0, keyList.ElementAt(bb).Count());
                        newMessage = newMessage + "-" + keyList.ElementAt(bb).ElementAt(index) + "_";
                        
                        //make a copy of the index
                        RepeatList.ElementAt(bb).Add(keyList.ElementAt(bb).ElementAt(index));
                        //remove the copy of the index
                        keyList.ElementAt(bb).RemoveAt(index);
                        other = true;
                    }
                   
                 
                }

                   if( other == false)
                    {   //this replaces unparseable things with !
                        //from a cyrptology standpoint i think it is better to substitute in random 
                       //  newMessage = newMessage + "-!_";
                    //things from the key instead of making it obvious that an error orrured

                    Random seed = new Random();
                    int maxLetters = 0; ;
                    for(int i=0; i < keyList.Count(); i++)
                    {
                        if (keyList.ElementAt(i).Count()> maxLetters)
                        {
                            maxLetters = i;
                        }
                    }
                    int index = seed.Next(0, keyList.ElementAt(maxLetters).Count());
                    int letterCode= keyList.ElementAt(maxLetters).ElementAt(index);
                    newMessage = newMessage + "-" + letterCode + "_";




                    other = true;
                       
                    }
                    other = false;
                    

            }

            return newMessage;
        }


        public string keyGenWstar(string starter, long length)
        {
            string key="Hello World";
           

            for (int i=0; i < length; i++)
            {
                Random seed = new Random();
                int stringIndex = key.Count();
                int index = seed.Next(0, stringIndex);
                key = key + " " + key.ElementAt(index);
            }

            return key;
        }

             public string keyGen(long length)
        {
            List<string> Characters = new List<string>() { "0", "1",
"2", "3", "4", "5", "6", "7", "8", "9", "0", "q", "w", "e", "r", "t",
"y", "u", "i", "o", "p", "a", "s", "d", "f", "g", "h", "j", "k", "l",
"z", "x", "c", "v", "b", "n", "m", "!", " ", "@" };
            List<double> means = new List<double>() { 1, 2, 1, 1, 2,
1, 1, 2, 1, 1, 2, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2, 1, 2, 1, 1, 1,
1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            string key = "";
            while (key.Distinct().Count() < 39)
            {
                Random rend = new Random();
                for (int n = 0; n < 39; n++)
                {
                    double rendomnumber = rend.Next(0, 100000) / 100000;
                    for (int m = 0; m < 6; m++)
                    {
                        double lambda = means[n];
                        double poisson1 = Math.Pow(2.718, lambda) *
                        Math.Pow(lambda, m) / Factorial(m);
                        double poisson2 = Math.Pow(2.718, lambda) *
                        Math.Pow(lambda, m + 1) / Factorial(m + 1);
                        if ((poisson1 < rendomnumber) & (rendomnumber <
poisson2))
                        {
                            for (int p = 0; p < m; p++)
                            {
                                key += Characters[n];
                            }
                        }
                    }
                }
            }
            return key;
        }

        int Factorial(int i)
        {
            if (i <= 1)
                return 1;
            return i * Factorial(i - 1);
        }
      

        public string deConCeal(string codedMessge, string key)
        {
            string cleanedMessage = "";

            codedMessge.ToLower();
            key.ToLower();
            bool start = false;
            bool finish = false;
            string tempIndex = "";
            string indexkeys = "";
            string lettersFromKey = "";
            for (int i = 0; i < codedMessge.Count(); i++)
            {
                if (start == false && finish == false)
                {
                    if (codedMessge.ElementAt(i) != '-')
                    {
                        cleanedMessage = cleanedMessage + codedMessge.ElementAt(i);
                    }
                    // cleanedMessage = cleanedMessage + codedMessge.ElementAt(i);
                }

                if (codedMessge.ElementAt(i) == '_')
                {
                    finish = true;
                }


                if (start == true && finish == false)
                {

                    tempIndex = tempIndex + codedMessge.ElementAt(i).ToString();



                }

                if (start == true && finish == true)
                {
                    indexkeys = indexkeys + tempIndex + " ";
                    start = false;
                    finish = false;

                    int index;
                    char letter=' ';
                    bool decoded = false;

                    

                    if(int.TryParse(tempIndex,out index))
                    {
                        if (index >= key.Count())
                        {
                            Random r = new Random();
                            int tempNum = key.Count();
                            index = r.Next(0,tempNum);
                        }
                            
                       // int indexX = r.Next(0, keyList.ElementAt(bb).Count());

                        letter = key.ElementAt(index);
                        decoded = true;
                    }
                    if (decoded == false)
                    {
                        letter = tempIndex.ToCharArray().ElementAt(0);
                    }

                    lettersFromKey = lettersFromKey + letter;
                    cleanedMessage = cleanedMessage + letter;
                    tempIndex = "";
                }


                if (codedMessge.ElementAt(i) == '-')
                {
                    start = true;
                }


            }

           cleanedMessage=cleanedMessage.ToLower();
            return cleanedMessage;
           
        }



        public List<List<Int32>> letterDistributionMK2(String MessageToBeDistriubted)
        {
            MessageToBeDistriubted.ToLower();
            List<Int32> Aindex = new List<Int32>();
            List<Int32> Bindex = new List<Int32>();
            List<Int32> Cindex = new List<Int32>();
            List<Int32> Dindex = new List<Int32>();
            List<Int32> Eindex = new List<Int32>();

            List<Int32> Findex = new List<Int32>();
            List<Int32> Gindex = new List<Int32>();
            List<Int32> Hindex = new List<Int32>();
            List<Int32> Iindex = new List<Int32>();
            List<Int32> Jindex = new List<Int32>();
            List<Int32> Kindex = new List<Int32>();
            List<Int32> Lindex = new List<Int32>();
            List<Int32> Mindex = new List<Int32>();
            List<Int32> Nindex = new List<Int32>();
            List<Int32> Oindex = new List<Int32>();
            List<Int32> Pindex = new List<Int32>();
            List<Int32> Qindex = new List<Int32>();
            List<Int32> Rindex = new List<Int32>();
            List<Int32> Sindex = new List<Int32>();
            List<Int32> Tindex = new List<Int32>();
            List<Int32> Uindex = new List<Int32>();
            List<Int32> Vindex = new List<Int32>();
            List<Int32> Windex = new List<Int32>();
            List<Int32> Xindex = new List<Int32>();
            List<Int32> Yindex = new List<Int32>();
            List<Int32> Zindex = new List<Int32>();
            List<Int32> Spaceindex = new List<Int32>();
            List<Int32> Periodindex = new List<Int32>();
            List<Int32> Atindex = new List<Int32>();

            List<Int32> Zeroindex = new List<Int32>();
            List<Int32> Oneindex = new List<Int32>();
            List<Int32> Twoindex = new List<Int32>();
            List<Int32> Threeindex = new List<Int32>();
            List<Int32> Fourindex = new List<Int32>();
            List<Int32> Fiveindex = new List<Int32>();
            List<Int32> Sixindex = new List<Int32>();
            List<Int32> Sevenindex = new List<Int32>();
            List<Int32> Eightindex = new List<Int32>();
            List<Int32> Nineindex = new List<Int32>();

            List<List<Int32>> Distribution = new List<List<Int32>>();
            Distribution.Add(Aindex); //0
            Distribution.Add(Bindex); //1
            Distribution.Add(Cindex);//2
            Distribution.Add(Dindex);//3
            Distribution.Add(Eindex);//4
            Distribution.Add(Findex); //0
            Distribution.Add(Gindex);
            Distribution.Add(Hindex); //1
            Distribution.Add(Iindex);//2
            Distribution.Add(Jindex);//3
            Distribution.Add(Kindex);//4
            Distribution.Add(Lindex); //0
            Distribution.Add(Mindex); //1
            Distribution.Add(Nindex);//2
            Distribution.Add(Oindex);//3
            Distribution.Add(Pindex);//4
            Distribution.Add(Qindex); //0
            Distribution.Add(Rindex); //1
            Distribution.Add(Sindex);//2
            Distribution.Add(Tindex);//3
            Distribution.Add(Uindex);//4
            Distribution.Add(Vindex); //0
            Distribution.Add(Windex); //1
            Distribution.Add(Xindex);//2
            Distribution.Add(Yindex);//3
            Distribution.Add(Zindex);//4
            Distribution.Add(Spaceindex);//2
            Distribution.Add(Periodindex);//3
            Distribution.Add(Atindex);//4
            Distribution.Add(Zeroindex);//3
            Distribution.Add(Oneindex);//4
            Distribution.Add(Twoindex); //0
            Distribution.Add(Threeindex); //1
            Distribution.Add(Fourindex);//2
            Distribution.Add(Fiveindex);//3
            Distribution.Add(Sixindex);//4
            Distribution.Add(Sevenindex);//2
            Distribution.Add(Eightindex);//3
            Distribution.Add(Nineindex);//4



            List<Char> alphabetList = new List<char>();
            String alphabetString = "abcdefghijklmnopqrstuvwxyz .@0123456789";
            int alaphbetstringLenght = alphabetString.Count();
            // For loop populates alphabetList from the alphabetList String
            for (int c = 0; c < alphabetString.Count(); c++)
            {
                char temp = alphabetString.ElementAt(c);
                alphabetList.Add(temp);
            }



            for (int i = 0; i < MessageToBeDistriubted.Count(); i++)
            {


                char temp = MessageToBeDistriubted.ElementAt(i);

                for(int aa=0; aa<alphabetList.Count(); aa++)
                {
                    if (temp == alphabetList.ElementAt(aa))
                    {
                        //error when encoding and decoding number 4 works, 9 fails
                        Distribution.ElementAt(aa).Add(i);
                    }
                }

                
            }

           






            return Distribution;

        }


    }


}