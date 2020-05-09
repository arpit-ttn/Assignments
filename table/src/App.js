import React,{Component} from 'react';
import AddFruitRow from './AddFruitRow';

class App extends Component {

  constructor(props)
  {
    super(props);
    this.state={
      fruitsList:[],
      inputText:' ',
      newFruitDetails:{
        name:' ',
        quantity:' '
      }
    }
  }

  /*It is called when input is given in the textbox and splits the fruit name and it's quantity 
  and update the newFruitDetails in the state */

  textboxHandler=(e)=>{

    let inputStr=e.target.value;
    let fruit=inputStr.split("-")[0];
    let quant=inputStr.split("-")[1];
    this.setState({
      inputText:inputStr,
      newFruitDetails:{
        name:fruit,
        quantity:quant
      }
    })
  }

  /*This is called when add fruit button is clicked,
  and new fruit is added in the table by adding the fruit in the fruitList array in the state*/

  newFruit=(e)=>{

   e.preventDefault();
    const newFruitDetails=this.state.newFruitDetails;
    if(newFruitDetails.name!== " " )
    {
      const items=[...this.state.fruitsList,newFruitDetails];
      this.setState({
        fruitsList:items,
        inputText:' ',
        newFruitDetails:{
         name:' ',
          quantity:' '
       }
      });
    }
  }

  /*This event is called when Remove button is clicked and 
  it updates the fruitsList array in the state with the remaining fruits*/

  removeFruitRecord=(name)=>{
    const remainingFruits=this.state.fruitsList.filter(item => item.name!==name);
      console.log(remainingFruits);
      this.setState({
        fruitsList:remainingFruits
      })
  }

  render(){

  return (
  <div>
    <form onSubmit={this.newFruit} >
      <input type="text" placeholder="Enter fruit and quantity"  value={this.state.inputText} onChange={this.textboxHandler}></input>
      <button  type="submit">Add Fruit</button>
    </form>
    <p>{this.state.fruitsList.name}</p>
    <table >
      <thead>
        <tr>
        <th>
          Fruit
        </th>
        <th>
          Quantity
        </th>
        <th></th>
        </tr>
      </thead>
      <tbody>
        <AddFruitRow fruitsList={this.state.fruitsList} removeFruitRecord={this.removeFruitRecord}></AddFruitRow>
      </tbody>
    </table>
    </div>
  );
}}

export default App;