using Android.App;
using System;
using System.Collections.Generic;
using System.Text;

namespace Flames.service
{
    public class FlamesService

    {


        public string  calculateFlames(string name, string partnerName) {

            var length = getNameLength(name, partnerName);
            int index = 0;

            while ("FLAMES".Length != 1)
            {

                index = length % 6;



                if (index == 0)
                {

                    FLAMES = FLAMES.replace(String.valueOf(arr_FLAMES[FLAMES.length() - 1]), "");

                    arr_FLAMES = FLAMES.toCharArray();

                }
                else
                {

                    FLAMES = FLAMES.replace(String.valueOf(arr_FLAMES[index - 1]), "");

                    FLAMES = FLAMES.substring(index - 1) + FLAMES.substring(0, index - 1);

                    arr_FLAMES = FLAMES.toCharArray();

                }



                flamesLength--;

            }



        }

        private int getNameLength(string name, string partnerName)
        {
            char[] nameArray = name.Replace(" ", "").ToUpper().ToCharArray();
            char[] partnerNameArray = partnerName.Replace(" ", "").ToUpper().ToCharArray();
            string result = "";

            int index, index1;
            for (index = 0; index < nameArray.Length; index++)
            {

                for (index1 = 0; index1 < partnerNameArray.Length; index1++)
                {

                    if (nameArray[index] == partnerNameArray[index1])
                    {

                        nameArray[index] = partnerNameArray[index1] = ' ';
                        break;

                    }

                }

            }

            result = new string(nameArray).Replace(" ", "") + new string(partnerNameArray).Replace(" ", "");
            return result.Length;   
        }

    }
}
