namespace DataValidation.Utilis
{
    public class CpfUtilis
    {
        public bool CPF_validation(string cpf)
        {

            int Mult = 10;
            int sum = 0;
            int rest = 0;
            int FirstDig = 0;
            int SecondDig = 0; 
            for (int i = 0; i < 9; i++)
            {
                sum += int.Parse(cpf[i].ToString()) * Mult;
                Mult--;
            }
            rest = sum % 11;

            if(rest < 2)
            {
                FirstDig = 0;
            }else
            {
                FirstDig = 11 - rest;
            }

            Mult = 11;
            sum = 0;
            for (int i = 0; i < 10; i++)
            {
                sum += int.Parse(cpf[i].ToString()) * Mult;
                Mult--;
            }
            rest = sum % 11;

            if (rest < 2)
            {
                SecondDig = 0;
            }
            else
            {
                SecondDig = 11 - rest;
            }

            if(FirstDig == int.Parse(cpf[9].ToString()) && SecondDig == int.Parse(cpf[10].ToString()))
            {
               return true;
            }
            else { return false;}
        }
        public int CPF_Create()
        {
            return 20;
        }
    }

}
