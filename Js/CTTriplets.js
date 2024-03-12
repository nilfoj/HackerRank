    let alice = 0;
    let bob = 0;

    for(let i = 0; i < alice.length; i += 1)
    {

        if(a[i] > b[i]){
            alice += 1;
        }

        else if(a[i] < b[i]){
            bob += 1;
        }
        
    }

    console.log(`Alice: ${alice}, Bob: ${bob}`);
    return [alice, bob];