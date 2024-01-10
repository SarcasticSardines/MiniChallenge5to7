namespace MC5to7.Services.ReverseItAlpha;

    public class ReverseItAlpha : IReverseItAlpha
    {

        public string GetRAlpha(string reverseAlpha)
        {
            string finalAlpha = "";

            for(int i = reverseAlpha.Length; i > 0; i--)
            {
                finalAlpha = (finalAlpha + "" + (reverseAlpha[i-1]));
            }
            return finalAlpha;
        }
        
    }
