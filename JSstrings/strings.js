strings = document.getElementById("string").value;

function length () {

    strings = document.getElementById("string").value;
    leng = strings.length;
      
    document.getElementById("out").innerHTML = leng;

}

function separ () {
    strings = document.getElementById("string").value;

sep = strings.split("");
document.getElementById("out").innerHTML = sep;
}

function numwrds () {
    strings = document.getElementById("string").value;
    count = strings.replace(/(^\s*)|(\s*$)/gi,"");

    count = strings.replace(/[ ]{2,}/gi," ");

    count = strings.replace(/\n /,"\n");


    document.getElementById("out").innerHTML = strings.split(' ').length;

}

function alpha () {

    const specialChars = /[`!@#$%^&*()_+\-=\[\]{};':"\\|,.<>\/?~]/;
    strings = document.getElementById("string").value;

    document.getElementById("out").innerHTML= "Digits:" + (strings.replace(/[^0-9]/g,"").length) + '\n' + "Alphabets:" + (strings.replace(/[^a-z]/gi, "").length) + "\n" +  "Special Characters:" + specialChars.test(strings);

    

}

function voworcon () {
    strings = document.getElementById("string").value;
  
    document.getElementById("out").innerHTML = "Vowels: " + strings.match(/[aeiou]/gi).length +"\n"+ "Consonant: " + strings.match(/[bcdfgjklmnpqstvxzhrwy]/gi).length ;

}

function cosole () {
    strings = document.getElementById("string").value;

    if(strings.length < 20) {

        console.log(strings.padEnd(20,'*'));
        document.getElementById("out").innerHTML = (strings.padEnd(20,'*'));
    }

    else if (strings.length == 20){
        console.log("Correct Length");
        document.getElementById("out").innerHTML = "Correct Length";

    }

  
} 

function reverse () {

    strings = document.getElementById("string").value;
   
    document.getElementById("out").innerHTML =  strings.split("").reverse().join("");

}

function parenth () {
 strings = document.getElementById("string").value;
     const isValid = (strings = '') => {
         const map=new Map();
       map.set('{','}');
         map.set('(',')');
         map.set('(  )');
         map.set('[',']');
     const b=[];
        for(let i=0;i<strings.length;i++){
          if(map.has(strings.charAt(i))){
            b.push(strings.charAt(i));
           } else{
            let pop=b.pop();
           if(map.get(pop)!==strings.charAt(i)){
    return false;
              }
            };
         };
         return b.length===0;
      };
      document.getElementById("out").innerHTML = (isValid(strings));

    }

    function sub () {
        strings = document.getElementById("string").value;
        check = prompt("Find the substring");
        // see =  (strings.match(check) || []).length;
        let count = 0;
         
        for (let i in strings) { 
            if (strings [i]== check ) {
              count++;
            }
        }
          alert(count);
    }

    function ext () {
        strings = document.getElementById("string").value;
        ex = prompt("Enter a number to extract");
        
        subs = strings.slice(ex);
        document.getElementById("out").innerHTML = subs;

    }

function chek () {
    strings = document.getElementById("string").value;
   find = prompt("Enter a substring to check if its in the string.");
   if (strings.includes(find)) 
   document.getElementById("out").innerHTML  = `The substring <b>\"${find}\"</b> IS included in the string <b>\"${strings}\"</b>`;
else
document.getElementById("out").innerHTML =  `The substring <b>\"${find}\"</b> is NOT included in the string <b>\"${strings}\"</b>`;
}


function compar () {
   comp1 = prompt("Enter a string");
   comp2 = prompt("Enter a second string");

   if (comp1 == comp2){
    document.getElementById("out").innerHTML= (comp1 + "\n" + "is equal to"  + "\n" + comp2);
   }
    else {
        document.getElementById("out").innerHTML= (comp1 + "\n" + "is not equal to"  + "\n" + comp2);   }


}

function kount () {
    strings = document.getElementById("string").value;
    chara = prompt("Enter a Character");
    // see =  (strings.match(check) || []).length;
    let count = 0;
     
    for (let i in strings) { 
        if (strings [i]== chara ) {
          count++;
        }
    }
      alert(count);
}








  



