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
            // For loop populates alphabetList from the alphabetList String
            for (int c = 0; c < alphabetString.Count(); c++)
            {
                char temp = alphabetString.ElementAt(c);
                alphabetList.Add(temp);
            }


            /*
            for (int i = 0; i < MessageToBeDistriubted.Count(); i++)
            {


                char temp = MessageToBeDistriubted.ElementAt(i);

                for (int aa = 0; aa < alphabetList.Count(); aa++)
                {
                    if (temp == alphabetList.ElementAt(aa))
                    {
                        Distribution.ElementAt(aa).Add(i);
                    }
                }

            */


                bool encoded = false;
            for (int b = 0; b < message.Count(); b++)
            {


                char temp = message.ElementAt(b);

                for (int bb = 0; bb < alphabetList.Count(); bb++)
                {
                    if (temp == alphabetList.ElementAt(bb))
                    {
                        Random r = new Random();
                        int index = r.Next(1, keyList.ElementAt(bb).Count());
                        newMessage = newMessage + "-" + keyList.ElementAt(bb).ElementAt(index) + "_";
                        keyList.ElementAt(bb).RemoveAt(index);


                    }


                }


                /*
                if (message.ElementAt(b) == 'a' && encoded == false)
                {

                    //we need to take a random one from a list, then add it, then remove it
                    Random r = new Random();
                    int index = r.Next(1, keyList.ElementAt(0).Count());
                    newMessage = newMessage + "-" + keyList.ElementAt(0).ElementAt(index) + "_";
                    keyList.ElementAt(0).RemoveAt(index);
                    encoded = true;
                }

                if (message.ElementAt(b) == 'b' && encoded == false)
                {

                    //we need to take a random one from a list, then add it, then remove it
                    Random r = new Random();
                    int index = r.Next(1, keyList.ElementAt(1).Count());
                    newMessage = newMessage + "-" + keyList.ElementAt(1).ElementAt(index) + "_";
                    keyList.ElementAt(1).RemoveAt(index);
                    encoded = true;
                }


                if (message.ElementAt(b) == 'c' && encoded == false)
                {

                    //we need to take a random one from a list, then add it, then remove it
                    //int index = keyList.ElementAt(2).Count() - 1;
                    Random r = new Random();
                    int index = r.Next(1, keyList.ElementAt(2).Count());
                    newMessage = newMessage + "-" + keyList.ElementAt(2).ElementAt(index) + "_";
                    keyList.ElementAt(2).RemoveAt(index);
                    encoded = true;
                }

                if (message.ElementAt(b) == 'd' && encoded == false)
                {

                    Random r = new Random();
                    int index = r.Next(1, keyList.ElementAt(3).Count());
                    newMessage = newMessage + "-" + keyList.ElementAt(3).ElementAt(index) + "_";
                    keyList.ElementAt(3).RemoveAt(index);
                    encoded = true;
                    //tacos for jlofdd rrr
                }

                if (message.ElementAt(b) == 'e' && encoded == false)
                {

                    Random r = new Random();
                    int index = r.Next(1, keyList.ElementAt(4).Count());
                    newMessage = newMessage + "-" + keyList.ElementAt(4).ElementAt(index) + "_";
                    keyList.ElementAt(4).RemoveAt(index);
                    encoded = true;
                }







                if (encoded == false)
                {
                    newMessage = newMessage + message.ElementAt(b);
                    encoded = true;
                }


                encoded = false;

            */

            }

            return newMessage;
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
                    int index = int.Parse(tempIndex);
                    char letter = key.ElementAt(index);
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
                        Distribution.ElementAt(aa).Add(i);
                    }
                }

                /*if (MessageToBeDistriubted.ElementAt(i) == 'a')
                {
                    Aindex.Add(i);
                }
                if (MessageToBeDistriubted.ElementAt(i) == 'b')
                {
                    Bindex.Add(i);
                }
                if (MessageToBeDistriubted.ElementAt(i) == 'c')
                {
                    Cindex.Add(i);
                }
                if (MessageToBeDistriubted.ElementAt(i) == 'd')
                {
                    Dindex.Add(i);
                }
                if (MessageToBeDistriubted.ElementAt(i) == 'e')
                {
                    Eindex.Add(i);
                }
                */
            }

           






            return Distribution;

        }


    }


}