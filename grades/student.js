var student = [];

function stu () {

var pad = {
n1: '',
c1: '',
c2: '',
c3: '',
c4: '',
s1: '',
s2: '',
s3: '',
s4: '',
}

pad.n1 = document.getElementById("name1").value;
pad.c1 = document.getElementById("class1").value;
pad.c2 = document.getElementById("class2").value;
pad.c3 = document.getElementById("class3").value;
pad.c4 = document.getElementById("class4").value;
pad.s1 = document.getElementById("numb1").value *1;
pad.s2 = document.getElementById("numb2").value * 1;
pad.s3 = document.getElementById("numb3").value * 1;
pad.s4 = document.getElementById("numb4").value * 1;
pad.avg = pad.s1 + pad.s2 + pad.s3 + pad.s4 / 4;

student.push(pad);
localStorage.setItem('student', JSON.stringify(student));


}


function store () {
    var storage = JSON.parse(localStorage.getItem('student'));
     var list = ' ';

     for (var i = 0; i < storage.length; i++) {
        list += '<tr>\
                                <td>'+ storage[i].n1 +'</td>\
                                <td>'+ storage[i].c1 + '<br>' +storage[i].c2 +'<br>'+ storage[i].c3 +'<br>'+ storage[i].c4 +'</td>\
                                <td>'+ "Student Average:" + storage[i].avg + '<br>' + storage[i].s1 + '<br>' +storage[i].s2 +'<br>'+ storage[i].s3 +'<br>'+ storage[i].s4 +'</td>\
                            </tr >'; 
    }

    document.getElementById('rowsData').innerHTML = list + '</tbody>';
    document.getElementById('displayData').style.visibility = 'visible';
}