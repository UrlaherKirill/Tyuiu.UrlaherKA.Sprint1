using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.UrlaherKA.Sprint1.Task6.V9.Lib
{
    public class DataService : ISprint1Task6V9
    {
        public string MoveLetterToStart(string value)
        {
            string Final_string = "";
            string[] split_str = value.Split(' ');
            for(var i = 0; i < split_str.Length; i++)
            {
                string Temp_Str = split_str[i];
                char Temp_Char = Temp_Str[^1];
                string Temp_Str_Without_Last = Temp_Str.Remove(Temp_Str.Length-1);
                Final_string = Final_string + Temp_Char + Temp_Str_Without_Last + " ";
            }
            return Final_string.Trim();
        }
    }
}
