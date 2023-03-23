let mod = [];




function regi() {
    let task = {}
    task.full = document.getElementById('full').value;
    task.user = document.getElementById('user').value;
    task.pass = document.getElementById('pass').value;
   


    if (task.full == "") {
        alert("Please enter your full name.")
    }
    if (task.user == "") {
        alert("Please enter your username.")
    }

    if (task.pass == "") {
        alert("Please enter your password.")
    }

    else {
        alert("you have succesfully registered!");
        window.open("index.html");
    }

    mod.push(task);

    localStorage.setItem('mod', JSON.stringify(mod));

    

}



function login() {
    // task.user = document.getElementById('user').value;
    // task.pass = document.getElementById('pass').value;

    if (mod.user == "") {
        alert("Please enter your username.")
    }

    if (mod.pass == "") {
        alert("Please enter your password.")
    }

    else {
        alert("you have succesfully log in!");
        window.open("tasks.html");
    }

}
function save() {
    let takz = {};

    takz.taks = document.getElementById("tas").value;
    takz.status = "incomplete"
    let tas = JSON.parse(localStorage.getItem("tas"))
    if (tas == null) {
        tas = []
    }
    tas.push(takz);

    localStorage.setItem('tas', JSON.stringify(tas));
    show();
}


function togglestat(i) {
    let tas = JSON.parse(localStorage.getItem("tas"))
    console.log(tas);
    tas[i].status == "incomplete" ? tas[i].status = "complete" : tas[i].status = "incomplete"

    localStorage.setItem('tas', JSON.stringify(tas));



}
function complet() {
    var storage = JSON.parse(localStorage.getItem('tas'));
    var list = ' ';

    for (var i = 0; i < storage.length; i++) {
        if (storage[i].status == "complete") {


            list += '<tr>\
                               <td onclick="togglestat('+ i + ') ">' + storage[i].taks + '</td>\
                               </td>\
                               <td>\
                               </td>\
                               <td>\
                               <button class="btn btn-link" onclick="dele('+ i + ')"><i class="bi bi-trash"></i></button>\
                               <td>\
                           </tr >';
        }
    }

    document.getElementById('rowsData').innerHTML = list + '</tbody>';
    document.getElementById('displayData').style.visibility = 'visible';

}

function incom() {
    var storage = JSON.parse(localStorage.getItem('tas'));
    var list = ' ';

    for (var i = 0; i < storage.length; i++) {
        if (storage[i].status == "incomplete") {


            list += '<tr>\
                               <td onclick="togglestat('+ i + ') ">' + storage[i].taks + '</td>\
                               </td>\
                               <td>\
                               </td>\
                               <td>\
                               <button class="btn btn-link" onclick="dele('+ i + ')"><i class="bi bi-trash"></i></button>\
                               <td>\
                           </tr >';
        }
    }

    document.getElementById('rowsData').innerHTML = list + '</tbody>';
    document.getElementById('displayData').style.visibility = 'visible';


}

function remove() {
    var storage = JSON.parse(localStorage.getItem('tas'));
    var fist = ' ';

    for (var i = 0; i < storage.length; i++) {
        if (storage[i].status == "incomplete") {


            fist += '<tr>\
                               <td onclick="togglestat('+ i + ') ">' + storage[i].taks + '</td>\
                               </td>\
                               <td>\
                               </td>\
                               <td>\
                               <button class="btn btn-link" onclick="dele('+ i + ')"><i class="bi bi-trash"></i></button>\
                               <td>\
                           </tr >';
        }
    }

    document.getElementById('rowsData').innerHTML = fist + '</tbody>';
    document.getElementById('displayData').style.visibility = 'visible';







}


function show() {
    

 


    var storage = JSON.parse(localStorage.getItem('tas'));
    var list = ' ';

    for (var i = 0; i < storage.length; i++) {
        list += '<tr>\
                               <td onclick="togglestat('+ i + ') ">' + storage[i].taks + '</td>\
                               </td>\
                               <td>\
                               </td>\
                               <td>\
                               <button class="btn btn-link" onclick="dele('+ i + ')"><i class="bi bi-trash"></i></button>\
                               <td>\
                           </tr >';
    }

    document.getElementById('rowsData').innerHTML = list + '</tbody>';
    document.getElementById('displayData').style.visibility = 'visible';
 
    

}

function dele(index) {
    var dataOnLS = JSON.parse(localStorage.getItem('tas'));
    dataOnLS.splice(index, 1);
    localStorage.setItem('tas', JSON.stringify(dataOnLS));
    var dataOnLS = JSON.parse(localStorage.getItem('tas'));

    show();

}
