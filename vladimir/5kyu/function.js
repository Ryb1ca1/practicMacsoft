function zeros (n) {
    let countZeros = 0;
    let currentMultipleOfFive = 5;
    
    while(n >= currentMultipleOfFive){
        countZeros += Math.floor(n/currentMultipleOfFive);
        currentMultipleOfFive *= 5;
    }
    return countZeros;
}