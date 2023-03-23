var recipes = {
  instructions: ' ',
  time: ' ',
  nam: ' ',
  pictures: ' ',
};


const filez = document.querySelector("#filez");

filez.addEventListener("change", function () {

 
  const reader = new FileReader();
  reader.addEventListener("load", () => {
    let canv1 = reader.result;
    recipes.pictures = reader.result;
    document.querySelector("#canv").style.backgroundImage = `url(${canv1})`;
  });
  reader.readAsDataURL(this.files[0]);
});




function submitrecipe() {
    recipes.instructions = document.getElementById("instruct").value;
    recipes.time = document.getElementById("cooktime").value * 1;
    recipes.nam = document.getElementById("recipename").value;
    var storage = JSON.parse(localStorage.getItem('recipes'));
    console.log(storage)
    if (storage == null) {
      storage = []
    }
    storage.push(recipes);
    localStorage.setItem('recipes', JSON.stringify(storage));
    

}


function store () {
  var storage = JSON.parse(localStorage.getItem('recipes'));
   var list = ' ';

   for (var i in storage) {
      list += `<tr>\
                              <td>${storage[i].nam}</td>\
                              <td>${storage[i].instructions}</td>\
                              <td>${storage[i].time}</td>\
                              <td><img src="`+ storage[i].pictures + `" style="width: 64px; height: 64px; border:ridge; border-radius: 5px"</td>\
                              <td><button class="btn btn-link" onclick="destroy('+ i + ')"><i class="bi bi-trash"></i></button></td>\
                              <td>\
                          </tr >`; 
  }
  document.getElementById('rowsData').innerHTML = list + '</tbody>';
  document.getElementById('displayData').style.visibility = 'visible';
}

function destroy(index) {
  var dataOnLS = JSON.parse(localStorage.getItem('recipes'));
  dataOnLS.splice(index, 1);
  localStorage.setItem('recipes', JSON.stringify(dataOnLS));
  var dataOnLS = JSON.parse(localStorage.getItem('recipes'));

  store();



}

function erased() {
  document.getElementById('instruct').value = ' ';
  document.getElementById('cooktime').value = ' ';
  document.getElementById('recipename').value = ' ';


}