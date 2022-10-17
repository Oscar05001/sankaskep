string[,] spel1= new string[,] {{"-","-","-","-"},
                                {"-","-","-","-"}, 
                                {"-","-","-","-"},
                                {"-","-","-","-"}}; 

string[,] spel2= new string[,] {{"-","-","-","-"},
                                {"-","-","-","-"}, 
                                {"-","-","-","-"},
                                {"-","-","-","-"}}; 

string[,] spelplan1= new string[,] {{"-","-","-","-"},
                                {"-","-","-","-"}, 
                                {"-","-","-","-"},
                                {"-","-","-","-"}}; 

string[,] spelplan2= new string[,] {{"-","-","-","-"},
                                {"-","-","-","-"}, 
                                {"-","-","-","-"},
                                {"-","-","-","-"}}; 

string i = "2";

int speltur = 1;   
bool klar = false;

int X = 0;
int Y = 0;
int hurspelare = 0;

Console.Clear();
Console.WriteLine("Hur många spelare? (en eller två)");
do
{
hurspelare = int.Parse(Console.ReadLine());
} while(hurspelare<0 && hurspelare>2);
Console.Clear();




int skep = 1;
Console.Clear();
Console.WriteLine("Hur många skep ska ni spela med?");
do
{
skep = int.Parse(Console.ReadLine());
} while(skep<0 && skep>16);
Console.Clear();
int liv1 = skep;
int liv2 = skep;

//väljer spleplan med dator
if(hurspelare==1){
//spelar 1 väljer
for(int re=0;re<skep; ++re)
{
Console.WriteLine("1  X| [1]  [2]  [3]  [4]");
Console.WriteLine("_Y__|___________________");
Console.WriteLine("[1] | |"+ spelplan1[0,0]+"|  |"+ spelplan1[0,1]+"|  |"+ spelplan1[0,2]+"|  |"+ spelplan1[0,3]+"|");
Console.WriteLine("    |-------------------");
Console.WriteLine("[2] | |"+ spelplan1[1,0]+"|  |"+ spelplan1[1,1]+"|  |"+ spelplan1[1,2]+"|  |"+ spelplan1[1,3]+"|");
Console.WriteLine("    |-------------------");
Console.WriteLine("[3] | |"+ spelplan1[2,0]+"|  |"+ spelplan1[2,1]+"|  |"+ spelplan1[2,2]+"|  |"+ spelplan1[2,3]+"|");
Console.WriteLine("    |-------------------");
Console.WriteLine("[4] | |"+ spelplan1[3,0]+"|  |"+ spelplan1[3,1]+"|  |"+ spelplan1[3,2]+"|  |"+ spelplan1[3,3]+"|");

Console.WriteLine("Skriv X Kordinat:");
do
{
X = int.Parse(Console.ReadLine());
} while(X>4);

Console.WriteLine("Skriv Y Kordinat:");
do
{
Y = int.Parse(Console.ReadLine());
} while(Y>4);

if(spelplan1[Y-1,X-1]!="X")
{
spelplan1[Y-1,X-1] ="X";
Console.Clear();
}
else
{
Console.Clear();
Console.WriteLine("Är redan taget.");
}

}

Console.WriteLine("Nästa spelare ska välja!");
Console.ReadLine();
Console.Clear();



//Spelare 2/dator väljer plan
for(int re=0;re<skep;)
{

    //X kordinaterna 
    Random rd = new Random();
    int Xrd = rd.Next(1,4);

    //Y kordinaterna 
    Random rad = new Random();
    int Yrd = rad.Next(1,4);

    if(spelplan2[Yrd-1,Xrd-1]!="X")
    {
        spelplan2[Yrd-1,Xrd-1] ="X";
        Console.Clear();
        re = re+1;
    }
    else
    {
    }

}

}


//två spelare Väljer plan
if(hurspelare==2){
Console.Clear();
//Spelare 1 välje plan
for(int re=0;re<skep; ++re)
{
Console.WriteLine("1  X| [1]  [2]  [3]  [4]");
Console.WriteLine("_Y__|___________________");
Console.WriteLine("[1] | |"+ spelplan1[0,0]+"|  |"+ spelplan1[0,1]+"|  |"+ spelplan1[0,2]+"|  |"+ spelplan1[0,3]+"|");
Console.WriteLine("    |-------------------");
Console.WriteLine("[2] | |"+ spelplan1[1,0]+"|  |"+ spelplan1[1,1]+"|  |"+ spelplan1[1,2]+"|  |"+ spelplan1[1,3]+"|");
Console.WriteLine("    |-------------------");
Console.WriteLine("[3] | |"+ spelplan1[2,0]+"|  |"+ spelplan1[2,1]+"|  |"+ spelplan1[2,2]+"|  |"+ spelplan1[2,3]+"|");
Console.WriteLine("    |-------------------");
Console.WriteLine("[4] | |"+ spelplan1[3,0]+"|  |"+ spelplan1[3,1]+"|  |"+ spelplan1[3,2]+"|  |"+ spelplan1[3,3]+"|");

Console.WriteLine("Skriv X Kordinat:");
do
{
X = int.Parse(Console.ReadLine());
} while(X>4);

Console.WriteLine("Skriv Y Kordinat:");
do
{
Y = int.Parse(Console.ReadLine());
} while(Y>4);

if(spelplan1[Y-1,X-1]!="X")
{
spelplan1[Y-1,X-1] ="X";
Console.Clear();
}
else
{
Console.Clear();
Console.WriteLine("Är redan taget.");
}

}

Console.WriteLine("Nästa spelare ska välja!");
Console.ReadLine();
Console.Clear();

//Spelare 2 väljer plan
for(int re=0;re<skep; ++re)
{
Console.WriteLine("2  X| [1]  [2]  [3]  [4]");
Console.WriteLine("_Y__|___________________");
Console.WriteLine("[1] | |"+ spelplan2[0,0]+"|  |"+ spelplan2[0,1]+"|  |"+ spelplan2[0,2]+"|  |"+ spelplan2[0,3]+"|");
Console.WriteLine("    |-------------------");
Console.WriteLine("[2] | |"+ spelplan2[1,0]+"|  |"+ spelplan2[1,1]+"|  |"+ spelplan2[1,2]+"|  |"+ spelplan2[1,3]+"|");
Console.WriteLine("    |-------------------");
Console.WriteLine("[3] | |"+ spelplan2[2,0]+"|  |"+ spelplan2[2,1]+"|  |"+ spelplan2[2,2]+"|  |"+ spelplan2[2,3]+"|");
Console.WriteLine("    |-------------------");
Console.WriteLine("[4] | |"+ spelplan2[3,0]+"|  |"+ spelplan2[3,1]+"|  |"+ spelplan2[3,2]+"|  |"+ spelplan2[3,3]+"|");

Console.WriteLine("Skriv X Kordinat:");
do //X kordinaterna 
{
X = int.Parse(Console.ReadLine());
} while(X>4);

Console.WriteLine("Skriv Y Kordinat:");
do //Y kordinaterna 
{
Y = int.Parse(Console.ReadLine());
} while(Y>4);

if(spelplan2[Y-1,X-1]!="X")
{
spelplan2[Y-1,X-1] ="X";
Console.Clear();
}
else
{
Console.Clear();
Console.WriteLine("Är redan taget.");
}
}

}
Console.Clear();
Console.WriteLine("Press enter to start!");
Console.ReadLine();
Console.Clear();


// Spel kör
while(liv1>0 || liv2>0)
{

if(speltur==1) // Spelare 1 tur
{
Console.Clear();
Console.WriteLine("Det finns " +liv1+" kvar!");
Console.WriteLine("1  X| [1]  [2]  [3]  [4]");
Console.WriteLine("_Y__|___________________");
Console.WriteLine("[1] | |"+ spel1[0,0]+"|  |"+ spel1[0,1]+"|  |"+ spel1[0,2]+"|  |"+ spel1[0,3]+"|");
Console.WriteLine("    |-------------------");
Console.WriteLine("[2] | |"+ spel1[1,0]+"|  |"+ spel1[1,1]+"|  |"+ spel1[1,2]+"|  |"+ spel1[1,3]+"|");
Console.WriteLine("    |-------------------");
Console.WriteLine("[3] | |"+ spel1[2,0]+"|  |"+ spel1[2,1]+"|  |"+ spel1[2,2]+"|  |"+ spel1[2,3]+"|");
Console.WriteLine("    |-------------------");
Console.WriteLine("[4] | |"+ spel1[3,0]+"|  |"+ spel1[3,1]+"|  |"+ spel1[3,2]+"|  |"+ spel1[3,3]+"|");

Console.WriteLine("Skriv X Kordinat:");
do //X kordinaterna 
{
X = int.Parse(Console.ReadLine());
} while(X>4);

Console.WriteLine("Skriv Y Kordinat:");
do //Y kordinaterna 
{
Y = int.Parse(Console.ReadLine());
} while(Y>4);

//tittar ifal ett skep är där
if(spelplan2[Y-1,X-1]=="X")
{
spel1[Y-1,X-1] ="X";

liv1 = liv1 - 1;
Console.Clear();
Console.WriteLine("Träff!");
Console.WriteLine("");
}
else if(spelplan2[Y-1,X-1]=="-")
{
spel1[Y-1,X-1] ="O";
Console.Clear();
Console.WriteLine("Miss!");
Console.WriteLine("");
}
else{

Console.WriteLine("Är redan taget.");
}

if(liv1==0)
break;
if(liv2==0)
break;

Console.WriteLine("Det finns " +liv1+" kvar!");
Console.WriteLine("1  X| [1]  [2]  [3]  [4]");
Console.WriteLine("_Y__|___________________");
Console.WriteLine("[1] | |"+ spel1[0,0]+"|  |"+ spel1[0,1]+"|  |"+ spel1[0,2]+"|  |"+ spel1[0,3]+"|");
Console.WriteLine("    |-------------------");
Console.WriteLine("[2] | |"+ spel1[1,0]+"|  |"+ spel1[1,1]+"|  |"+ spel1[1,2]+"|  |"+ spel1[1,3]+"|");
Console.WriteLine("    |-------------------");
Console.WriteLine("[3] | |"+ spel1[2,0]+"|  |"+ spel1[2,1]+"|  |"+ spel1[2,2]+"|  |"+ spel1[2,3]+"|");
Console.WriteLine("    |-------------------");
Console.WriteLine("[4] | |"+ spel1[3,0]+"|  |"+ spel1[3,1]+"|  |"+ spel1[3,2]+"|  |"+ spel1[3,3]+"|");

Console.ReadLine();

if(liv2>0)
speltur = 2;
}

if(speltur==2) // Spelare 2 tur
{
Console.Clear();
Console.WriteLine("Det finns " +liv2+" kvar!");
Console.WriteLine("2  X| [1]  [2]  [3]  [4]");
Console.WriteLine("_Y__|___________________");
Console.WriteLine("[1] | |"+ spel2[0,0]+"|  |"+ spel2[0,1]+"|  |"+ spel2[0,2]+"|  |"+ spel2[0,3]+"|");
Console.WriteLine("    |-------------------");
Console.WriteLine("[2] | |"+ spel2[1,0]+"|  |"+ spel2[1,1]+"|  |"+ spel2[1,2]+"|  |"+ spel2[1,3]+"|");
Console.WriteLine("    |-------------------");
Console.WriteLine("[3] | |"+ spel2[2,0]+"|  |"+ spel2[2,1]+"|  |"+ spel2[2,2]+"|  |"+ spel2[2,3]+"|");
Console.WriteLine("    |-------------------");
Console.WriteLine("[4] | |"+ spel2[3,0]+"|  |"+ spel2[3,1]+"|  |"+ spel2[3,2]+"|  |"+ spel2[3,3]+"|");

Console.WriteLine("Skriv X Kordinat:");
do //X kordinaterna 
{
X = int.Parse(Console.ReadLine());
} while(X>4);

Console.WriteLine("Skriv Y Kordinat:");
do //Y kordinaterna 
{
Y = int.Parse(Console.ReadLine());
} while(Y>4);

//tittar ifal ett skep är där
if(spelplan1[Y-1,X-1]=="X")
{
spel2[Y-1,X-1] ="X";
liv2 = liv2 - 1;
Console.Clear();
Console.WriteLine("Träff!");
Console.WriteLine("");
}
else if(spelplan1[Y-1,X-1]=="-")
{
spel2[Y-1,X-1] ="O";
Console.Clear();
Console.WriteLine("Miss!");
Console.WriteLine("");
}
else{
Console.WriteLine("Är redan taget.");
}


if(liv1==0)
break;
if(liv2==0)
break;


Console.WriteLine("Det finns " +liv2+" kvar!");
Console.WriteLine("2  X| [1]  [2]  [3]  [4]");
Console.WriteLine("_Y__|___________________");
Console.WriteLine("[1] | |"+ spel2[0,0]+"|  |"+ spel2[0,1]+"|  |"+ spel2[0,2]+"|  |"+ spel2[0,3]+"|");
Console.WriteLine("    |-------------------");
Console.WriteLine("[2] | |"+ spel2[1,0]+"|  |"+ spel2[1,1]+"|  |"+ spel2[1,2]+"|  |"+ spel2[1,3]+"|");
Console.WriteLine("    |-------------------");
Console.WriteLine("[3] | |"+ spel2[2,0]+"|  |"+ spel2[2,1]+"|  |"+ spel2[2,2]+"|  |"+ spel2[2,3]+"|");
Console.WriteLine("    |-------------------");
Console.WriteLine("[4] | |"+ spel2[3,0]+"|  |"+ spel2[3,1]+"|  |"+ spel2[3,2]+"|  |"+ spel2[3,3]+"|");

Console.ReadLine();

if(liv1>0)
speltur = 1;
}

}
Console.Clear();

if(liv1==0)
    Console.WriteLine("Gratis spelare 1 du van!");

if(liv2==0)
    Console.WriteLine("Gratis spelare 2 du van!");






