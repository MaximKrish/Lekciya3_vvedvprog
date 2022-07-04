// Вид 1 методы которые ничего не принимают и ничего нне возвращают
void Method1()
{
    Console.WriteLine("Автор ......");
}
Method1(); //вызов  метода



//Вид2 методы которые что - то принимают и ничего не возвращают

void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2("Текст сообщения");



void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;    //++ инкримент, уменьшение на единичку - декримент


    }
}
Method21("Текст", 4); //4 - сколько раз мы хоти увидеть это сообщение 
                      //Method21(msg "Текст", count: 4) - явно указываем какому аргументу какое значение
                      //Method21(count: 4, msg:"новый текст")Method21(msg "Текст", count: 4)


//Вид3 методы которые что - то возвращают но ничего не  принимают 

int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);

//Вид4 методы которые что - то принимают и что то возвращают 

string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty; //"" вместо String.Empty означает пустая строка
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

string res = Method4(10, "asdf");// 10 сколько раз будем склеивать текст
Console.WriteLine(res);