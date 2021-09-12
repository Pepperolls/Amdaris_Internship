let myList = [];
let myInput = document.getElementById('myInput');
let toDoList = document.getElementById('toDoList');
let idToRemove = document.getElementById('idToRemove');

function showToDos() {
  try {
    let div = `<div></div>`;

    for (var toDo of myList) {
      div += `<p>Id: ${myList.indexOf(toDo) + 1}, To-Do: ${toDo}</p>`;
    }

    document.getElementById('toDoList').innerHTML = div;
  } catch (error) {
    return new Error(error);
  }
}

function addNewToDo() {
  try {
    myList.push(myInput.value);

    console.log(myList);

    showToDos();
  } catch (error) {
    return new Error(error);
  }
}

function removeToDoById() {
  try {
    myList.splice(idToRemove.value - 1, 1);

    console.log(myList);

    showToDos();
  } catch (error) {
    return new Error(error);
  }
}

function showToDoCount() {
  try {
    document.getElementById('toDoCount').value = myList.length;
  } catch (error) {
    return new Error(error);
  }
}

document.getElementById('addToDo').addEventListener('click', addNewToDo);
document.getElementById('removeToDo').addEventListener('click', removeToDoById);
document.getElementById('countToDos').addEventListener('click', showToDoCount);
