string [] stringArray1 = new string[4] {"Kazan", "Ufa", "Moscow", "253"};
string [] stringArray2 = new string[stringArray1.Length];
int count = 0;

for(int i = 0; i < stringArray1.Length; i++){
    if(stringArray1[i].Length <= 3){
        stringArray2[count] = stringArray1[i];
        count++;
    }
}
for(int i = 0; i < stringArray1.Length; i++){
    Console.Write($"{stringArray2[i]} ");
}
