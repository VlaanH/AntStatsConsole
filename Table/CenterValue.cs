namespace AntminerParser
{
    public class CenterValue
    {
       public static string addlength(string value,int idealLength)
        {
           
            for (int i = 0; value.Length<idealLength; i++)
            {
                if (i==1)
                {
                    value = " "+value;
                }
                else
                { i = 0;


                    value = value + " ";


                }
                
            }


            return value;

        }


    }
}