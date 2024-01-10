namespace MC5to7.Services.ReverseItNum;

public class ReverseItNum : IReverseItNum
{

    public string GetRNum(string reverseNum)
    {
        int num = 0;
        bool reverseN = int.TryParse(reverseNum, out num);
        string numResults = "";

        if (reverseN == true)
        {
            for (int i = reverseNum.Length; i > 0; i--)
            {
                numResults = (numResults + "" + (reverseNum[i - 1]));
            }
            return numResults;
        }
        else
        {
            return "Unable to execute, please enter numerical values only.";
        }
    }

}
