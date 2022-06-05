import './App.css';
import Views from './components/Views';
import { FoodContextProvider } from './FoodContext';

function App() {
  return (
    <FoodContextProvider>
      <div className="App">
        <div className="Views">
          <Views />
        </div>
      </div>
    </FoodContextProvider>
  );
}

export default App;
