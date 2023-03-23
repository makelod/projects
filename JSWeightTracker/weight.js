var weighttrack = {
    first: ' ',
    last: ' ',
    num: ' ',
    pictures: ' ',
    weight: ' ',
    measure: ' ',
  };
  

  
const filez = document.querySelector("#filez");

filez.addEventListener("change", function () {

 
  const reader = new FileReader();
  reader.addEventListener("load", () => {
    let canv1 = reader.result;
    weighttrack.pictures = reader.result;
    document.querySelector("#canv").style.backgroundImage = `url(${canv1})`;
  });
  reader.readAsDataURL(this.files[0]);
});


function submitweight() {
    weighttrack.first = document.getElementById("firname").value;
    weighttrack.last = document.getElementById("lasname").value;
    weighttrack.num = document.getElementById("phone").value;
    weighttrack.weight = document.getElementById("weight").value;
    weighttrack.measure = document.getElementById("measure").value;

    var storage = JSON.parse(localStorage.getItem('weighttrack'));
    console.log(storage)
    if (storage == null) {
      storage = []
    }
    storage.push(weighttrack);
    localStorage.setItem('weighttrack', JSON.stringify(storage));
    

}



function store () {
    var storage = JSON.parse(localStorage.getItem('weighttrack'));
     var list = ' ';
  
     for (var i in storage) {
        list += `<tr>\
                                <td>${storage[i].first}</td>\
                                <td>${storage[i].last}</td>\
                                <td>${storage[i].num}</td>\
                                <td>${storage[i].weight}</td>\
                                <td>${storage[i].measure}</td>\
                                <td><img src="`+ storage[i].pictures + `" style="width: 64px; height: 64px; border:ridge; border-radius: 5px"</td>\
                                <td><button class="btn btn-link" onclick="destroy('+ i + ')"><i class="bi bi-trash"></i></button></td>\
                                <td>\
                            </tr >`; 
    }
    document.getElementById('rowsData').innerHTML = list + '</tbody>';
    document.getElementById('displayData').style.visibility = 'visible';
  }