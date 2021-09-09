async function getFirstUser() {
  try {
    const response = await fetch(
      'https://jsonplaceholder.typicode.com/users/1'
    );

    var data = await response.json();

    console.log(data);

    let div = `<div>
                <p>Id: ${data.id} </p>
                <p>Name: ${data.name}</p>
                <p>Username: ${data.username}</p>
                <p>Email: ${data.email}</p>
                <p>Street: ${data.address.street}</p>
                <p>Suite: ${data.address.suite}</p>
                <p>City: ${data.address.city}</p>
                <p>Zipcode: ${data.address.zipcode}</p>
                <p>Phone: ${data.phone}</p>
                <p>Website: ${data.website}</p>
                <p>Company Name: ${data.company.name}</p>
               </div>`;

    document.getElementById('firstUser').innerHTML = div;
  } catch (error) {
    return new Error(error);
  }
}

async function getFirstFiveToDos() {
  try {
    const response = await fetch('https://jsonplaceholder.typicode.com/todos');

    var data = await response.json();

    console.log(data);
    let div = `<div></div>`;

    for (var toDo of data) {
      if (toDo.id > 5) break;

      div += `<p>Id: ${toDo.id}</p>
      <p>Title: ${toDo.title}</p>`;
    }

    document.getElementById('firstFiveToDos').innerHTML = div;
  } catch (error) {
    return new Error(error);
  }
}

document.getElementById('getFirstUser').addEventListener('click', getFirstUser);

document
  .getElementById('getFirstFiveToDos')
  .addEventListener('click', getFirstFiveToDos);
