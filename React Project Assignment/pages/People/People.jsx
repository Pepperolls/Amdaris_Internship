import React, { useEffect, useState } from 'react';
import axios from 'axios';
import Card from '../../components/Card/Card';
import Input from '../../components/Input/Input';

const People = () => {
  const [people, setPeople] = useState();
  const [searchBy, setSearchBy] = useState('');

  useEffect(() => {
    fetchPeople();
  }, []);

  const fetchPeople = async () => {
    const res = await axios.get('https://swapi.dev/api/people');
    const people = res.data.results;
    setPeople(people);
    console.log(people);
  };

  // const cardArray =
  //   people &&
  //   people.map(character => (
  //     <Card props={character} key={people.indexOf(character)}></Card>
  //   ));

  return (
    <div className="mainDiv">
      <form className="cardsForm">
        <br />
        <label>Character's name:</label>
        <input
          type="text"
          placeholder="Search..."
          onChange={event => {
            setSearchBy(event.target.value);
          }}
        />
      </form>

      <div className="cardsDiv">
        {people &&
          people
            .filter(value => {
              if (searchBy == '') {
                return value;
              } else if (
                value.name.toLowerCase().includes(searchBy.toLowerCase())
              ) {
                return value;
              }
            })
            .map((character, key) => {
              return (
                <Card props={character} key={people.indexOf(character)}></Card>
              );
            })}
      </div>
    </div>
  );
};

export default People;
