import React, {useState, useEffect} from 'react';
import { Route } from 'react-router-dom';
import logo from './logo.svg';
import './App.css';
import { render } from '@testing-library/react';
import Home from './pages/Home';
import About from './pages/About';
import Login from './pages/Login';

const App = () => {
  return(
    <div>
      <Route path="/" component={Home} exact/>
      <Route path="/about" component={About}/>
      <Route path="/login" component={Login}/>
    </div>
  )
}

// function App() {
//   const [message, setMessage] = useState("");
// useEffect(() => {
// fetch('/api/hello')
// .then(response => response.text())
// .then(message => {
// setMessage(message);
// });
// },[])

//   return (
//     <div className="App">
//       <header className="App-header">
//         <img src={logo} className="App-logo" alt="logo" />
//         <h1 className="App-title">{message}</h1>
//         <p>
//           Edit <code>src/App.js</code> and save to reload.
//         </p>
//         <a
//           className="App-link"
//           href="https://reactjs.org"
//           target="_blank"
//           rel="noopener noreferrer"
//         >
//           Learn React
//         </a>
//       </header>
//     </div>
//   );
// }

export default App;
