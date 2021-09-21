import axios from 'axios';
import React, { useEffect, useState } from 'react';

const Movies = () => {
  useEffect(() => {
    fetchMovies();
  }, []);

  const fetchMovies = async () => {
    const res = await axios.get('https://swapi.dev/api/films/');
    const movies = res.data.results;
    console.log(movies);
  };

  return (
    <div className="moviesDiv">
      <h3>List of Star Wars movies (release order)</h3>
      <h4>Original Trilogy</h4>
      <p>Episode IV – A New Hope</p>
      <p>Episode V – The Empire Strikes Back</p>
      <p>Episode VI – Return of the Jedi</p>
      <h4>Prequel trilogy</h4>
      <p>Episode I – The Phantom Menace</p>
      <p>Episode II – Attack of the Clones</p>
      <p>Episode III – Revenge of the Sith</p>
      <h4>Sequel Trilogy</h4>
      <p>Episode VII – The Force Awakens</p>
      <p>Episode VIII – The Last Jedi</p>
      <p>Episode IX – The Rise of Skywalker</p>
    </div>
  );
  {
    Array.map(element => <div>element.name</div>);
  }
};

export default Movies;
