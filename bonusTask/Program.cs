Console.Clear();

int [] bushes=new int[new Random().Next(3,1001)];
for (int i=0;i<bushes.Length; i++){
bushes[i]= new Random().Next(0,1001);
}
int max=0;
int current=0;
for (int i=0;i<bushes.Length; i++){
    if (i==0){
        current=bushes[i]+bushes[bushes.Length-1]+bushes[i+1];
        if(current>max)max=current;
    }else if(i==bushes.Length-1){
        current=bushes[i]+bushes[i-1]+bushes[0];
        if(current>max)max=current;
    }else{
        current=bushes[i-1]+bushes[i]+bushes[i+1];
        if(current>max)max=current;
    }

}
Console.Write($"between {bushes.Length} bushes the machine can harvest maximum {max} blueberries");