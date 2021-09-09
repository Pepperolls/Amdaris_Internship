async function getFirstUser() {
  const response = await fetch('https://jsonplaceholder.typicode.com/users/1');

  var data = await response.json();

  console.log(data);
  show(data);
}

getFirstUser();

function show(data) {
  let tab = `<tr>
          <th>Id</th>
          <th>Name</th>
          <th>Username</th>
          <th>Email</th>
          <th>Street</th>
          <th>Suite</th>
          <th>City</th>
          <th>Zipcode</th>
          <th>Phone</th>
          <th>Website</th>
          <th>Company Name</th>
         </tr>`;

  for (let r of data.list) {
    tab += `<tr> 
        <td>${r.id} </td>
        <td>${r.name}</td>
        <td>${r.username}</td> 
        <td>${r.email}</td>
        <td>${r.address.street}</td>    
        <td>${r.address.suite}</td>    
        <td>${r.address.city}</td>    
        <td>${r.address.zipcode}</td>    
        <td>${r.phone}</td>    
        <td>${r.website}</td>    
        <td>${r.company.name}</td>    
    </tr>`;
  }
  document.getElementById('user').innerHTML = tab;
}
