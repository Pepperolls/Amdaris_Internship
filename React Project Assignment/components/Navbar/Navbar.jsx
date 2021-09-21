import { NavLink } from 'react-router-dom';

const Navbar = () => {
  return (
    <nav>
      <div>
        <ul>
          <li>
            <NavLink to="/">Home</NavLink>
          </li>
          <li>
            <NavLink to="/people">People</NavLink>
          </li>
          <li>
            <NavLink to="/movies">Movies</NavLink>
          </li>
        </ul>
      </div>
    </nav>
  );
};

export default Navbar;
