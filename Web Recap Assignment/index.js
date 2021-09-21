function changeTheme() {
  var currentTheme = document.documentElement.getAttribute('theme');
  var switchToTheme = currentTheme === 'dark' ? 'light' : 'dark';
  document.documentElement.setAttribute('theme', switchToTheme);
}

document.getElementById('theme-changer').addEventListener('click', changeTheme);

async function getPeople() {
  try {
    const response = await fetch('https://swapi.dev/api/people');

    var data = await response.json();
    console.log(data);

    let div = `<div></div>`;

    while (data.next) {
      data.results.forEach(element => {
        console.log(element.name);
        div += `
      <div class="card">
      <div class="container">
         <h4>
           <b>Name: ${element.name} </b>
         </h4>
         <p>Gender: ${element.gender}</p>
         <p>Height: ${element.height}</p>
         <p>Mass: ${element.mass}</p>
         <p>Birth Year: ${element.birth_year}</p>
       </div>
      </div>`;
      });

      const next = await fetch(data.next);
      data = await next.json();
      console.log(data);
    }
    document.getElementById('mainDiv').innerHTML = div;
  } catch (error) {
    return new Error(error);
  }
}

getPeople();
