namespace Tasks
{
    public class Task2
    {
        /*
         * Construa um método que receba uma string contendo um valor e retorne um bool de acordo com a validação:
         * 
         * 3 Letras maiúsculas
         * 4 digitos (0-9)
         * 1 letra minúscula
         * 
         * Exemplos de entradas validas: 
         * 1 - ABC1234a
         * 2 - QAZ0987b
         * 3 - WSX1324c
         * 
         * Exemplos de entradas inválidas: 
         * 1 - ABC-1234
         * 2 - QAZ1987
         * 3 - abc1324
         * 4 - az111W
         */
        public static bool CheckInput(string input) {
            int maiusculas = 0, minusculas = 0, numeros = 0;

            if (input.Length != 8)
            {
                return false;
            }
            else
            {
                for (int i = 0; i < input.Length; i++)//ABC1239a
                {
                    if (char.IsUpper(input[i]))
                    {
                        maiusculas++;
                    }
                    else if (char.IsLower(input[i]))
                    {
                        minusculas++;
                    }
                    else if (char.IsNumber(input[i]))
                    {
                        numeros++;
                    }
                    else { return false; }
                }

                if (maiusculas != 3 || minusculas != 1 || numeros != 4)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }

        }
    }
}

