string[] Citys = new string[7] {"Москва", "Спб", "Пермь", "Екатеринбург", "Уфа", "Реж", "Владимир"};
string[] kolvo = new string[Citys.Length];

int count = 0;

for (int i = 0; i < Citys.Length; i++)
{
    if (Citys[i].Length <= 3 )
        {
            kolvo[count] = Citys[i];
            count++;
            Console.WriteLine(Citys[i]);
        }
}

