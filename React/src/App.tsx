import React from 'react';
import logo from './logo.svg';
import './App.css';

const App: React.FC = () => {
  return (
    <div className="App">
      <header className="App-header">
        <img src={logo} className="App-logo" alt="logo" />
        <h1>Code Challenge: Write a Component</h1>
        <div id="instructions">
          <h3>#1) Write a Component that...</h3>
          <ul>
              <li>Takes a Person Id property.</li>
              <li>Fetches <code>AbcService.GetAbcData()</code> for the given Person Id...
                <ul>
                  <li>... upon loading/mounting.</li>
                  <li>... everytime the Person Id changes and <i>only</i> if it changes.</li>
                </ul>
              </li>
              <li>Shows <code>&lt;A /&gt;</code> until <code>AbcService.GetAbcData()</code> returns.</li>
              <li>If <code>GetAbcData()</code>'s <code>result</code> is <code>true</code>, then show <code>&lt;B /&gt;</code>.</li>
              <li>If <code>GetAbcData()</code>'s <code>result</code> is <code>false</code>, then show <code>&lt;C /&gt;</code>.</li>
          </ul>

          <h3>#2) Use Component within <code>div#componentGoesHere</code>.</h3>
          <ul>
            <li>Use any Person Id you'd like.</li>
          </ul>
        </div>

        <hr />
        <div id="componentGoesHere">
          { /* Put component here. Use any Person Id you'd like. */ }
        </div>
        <hr />

        <a
          className="App-link"
          href="https://reactjs.org"
          target="_blank"
          rel="noopener noreferrer"
        >
          Learn React
        </a>
      </header>
    </div>
  );
}

export default App;
