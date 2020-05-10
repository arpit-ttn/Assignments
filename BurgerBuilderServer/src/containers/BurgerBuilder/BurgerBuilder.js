import React from 'react';
import Burger from '../../components/Burger/Burger';
import BuildControls from '../../components/Burger/BuildControls/BuildControls';
import Modal from '../../components/UserInterface/Modal/Modal';
import OrderSummary from '../../components/Burger/OrderSummary/OrderSummary';
import Aux from '../../hoc/Auxi';
import axios from '../../axios-orders';
import Spinner from '../../components/UserInterface/Spinner/Spinner';
import WithErrorHandler from '../../hoc/WithErrorHandler/WithErrorHandler';


const ingredientPrice ={
	salad:10,
	bacon:50,
	cheese:20,
	meat:80
}

class BurgerBuilder extends React.Component
{
	constructor()
	{
		super();
		this.state = {
			ingredients : {
				salad:0,
			cheese:0,
			meat:0,
			bacon:0
			},
		totalPrice:40,
		purchasable:false,
		purchasing:false,
		loading:false
		}

	}

	updatePurchasable(ingredients)
	{
		const sum = Object.keys(ingredients)
		.map(igkey=>{
			return ingredients[igkey];
		}).reduce((sum,ele)=>{
			return sum+ele;
		},0);
		this.setState({purchasable:sum>0})

	}

	addIngredientHandler=(type)=>
	{
		const oldCount = this.state.ingredients[type];
		const updateCount = oldCount+1;
		const updateIngredients = {...this.state.ingredients};
		updateIngredients[type]=updateCount;
		const priceAddition = ingredientPrice[type];
		const oldPrice = this.state.totalPrice;
		const newPrice = oldPrice+priceAddition;
		this.setState({totalPrice:newPrice,ingredients:updateIngredients})
		this.updatePurchasable(updateIngredients);

	}

	removeIngredientHandler=(type)=>
	{
		const oldCount = this.state.ingredients[type];
		if(oldCount<=0)
		{
			return;
		}
		const updateCount = oldCount-1;
		const updateIngredients = {...this.state.ingredients};
		updateIngredients[type]=updateCount;
		const priceDeduction = ingredientPrice[type];
		const oldPrice = this.state.totalPrice;
		const newPrice = oldPrice-priceDeduction;
		this.setState({totalPrice:newPrice,ingredients:updateIngredients})
		this.updatePurchasable(updateIngredients);

	}

	purchaseHandler = () =>
	{
		this.setState({purchasing:true})
	}

	purchaseCancelHandler = () =>
	{
		this.setState({purchasing:false})
	}

	purchaseContinueHandler = () =>
	{
		//alert('You Continue!');
		this.setState({loading:true});
        const order = {
			ingredients:this.state.ingredients,
			price: this.state.totalPrice,
			customer:{
				name:'Arpit Deora',
				address:{
					street:'GaurCity 1',
					zipCode:'21000',
					country:'India'

				},
				email:'a@gmail.com'

			},
			deliveryMethod:'fastest'
		}

		axios.post('/orders',order)
		   .then(response => {
			   this.setState({loading:false , purchasing:false});
		   })
		   .catch(error =>{
			this.setState({loading:false, purchasing:false});
		   });

	}


	render()
	{
		const disabledInfo = {...this.state.ingredients};
		for(let key in disabledInfo)
		{
			disabledInfo[key]=disabledInfo[key]<=0;
		}
		let orderSummary = <OrderSummary ingredients={this.state.ingredients}
		price={this.state.totalPrice}
		purchaseCancelled={this.purchaseCancelHandler}
		purchaseContinue={this.purchaseContinueHandler}/>;

        if (this.state.loading){
           orderSummary = <Spinner />;
		}

		return(
    <Aux>
		 <Modal show={this.state.purchasing} modelClosed={this.purchaseCancelHandler}>
       {orderSummary}
    </Modal>

    <Burger ingredients={this.state.ingredients} />

	<BuildControls ingredientAdded={this.addIngredientHandler} 
	ingredientRemoved={this.removeIngredientHandler}
    disabled={disabledInfo}
    purchasable={this.state.purchasable}
    purchasing={this.purchaseHandler}
    price={this.state.totalPrice}/>

	</Aux>
			)
	}
}

export default WithErrorHandler(BurgerBuilder,axios);