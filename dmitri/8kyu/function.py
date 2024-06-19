def fake_bin(x):
    TrueBinarycode=""
    for i in x:
        if i< "5":
            TrueBinarycode+= "0"
        elif i>= "5":
             TrueBinarycode+= "1"
    return TrueBinarycode