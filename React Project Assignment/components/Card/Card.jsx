import { NavLink } from 'react-router-dom';

const Card = ({ props }) => {
  return (
    props && (
      <div className="card">
        <div className="container">
          <h4>
            <b>Name: {props.name} </b>
          </h4>
          <p>Gender: {props.gender}</p>
          <p>Height: {props.height}</p>
          <p>Mass: {props.mass}</p>
          <p>Birth Year: {props.birth_year}</p>
          <NavLink to="/movies">Movies</NavLink>
        </div>
      </div>
    )
  );
};

export default Card;
