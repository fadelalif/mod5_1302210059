// See https://aka.ms/new-console-template for more information
using jurnalmod5_1302210059;
using static jurnalmod5_1302210059.Penjumlahan;

long a = 13;
long b = 02;
long c = 21;
JumlahTigaAngka<long> data = new JumlahTigaAngka<long>(a, b, c);
data.PrintData();

SimpleDataBase<int> dataBase= new SimpleDataBase<int>();

dataBase.AddNewData(13);
dataBase.AddNewData(02);
dataBase.AddNewData(21);
dataBase.printAllData();