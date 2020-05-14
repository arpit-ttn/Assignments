import React, { Component } from 'react'
import {connect} from 'react-redux';
import * as actionTypes from '../../store/action';

import Aux from '../../hoc/Auxiliary/Auxiliary'
import Burger from '../../components/Burger/Burger'
import BuildControls from '../../components/Burger/BuildControls/BuildControls'
import Modal from '../../components/UI/Modal/Modal'
import OrderSummary from '../../components/Burger/OrderSummary/OrderSummary'
import axios from '../../axios-order'
import Spinner from '../../components/UI/Spinner/Spinner'
import withErrorHandler from '../../hoc/withErrorHandler/withErrorHandler'

class BurgerBuilder extends Component {
    state = {
        
        purcahsing: false,
        loading: false,
        error: false
    }
    componentDidMount() {
        console.log(this.props);
        
        // axios.get('https://react-my-burger-a92bc.firebaseio.com/ingredients.json')
        //     .then(response => {
        //         this.setState({ ingredients: response.data })
        //     })
        //     .catch(error => {
        //         this.setState({ error: true })
        //     })
    }
    render() {
        const disabledInfo = {
            ...this.props.ings
        }
        for (let key in disabledInfo) {
            disabledInfo[key] = disabledInfo[key] <= 0
        }
        let orderSummary = null
        let burger = this.state.error ? <p>Sorry for the <strong>Incovenience..!</strong></p> : <Spinner />
        if (this.props.ings) {
            burger = (
                <Aux>
                    <Burger ingredients={this.props.ings} />
                    <BuildControls
                        ingredientAdded={this.props.onIngredientAdded}
                        ingredientRemoved={this.props.onIngredientRemoved}
                        disabled={disabledInfo}
                        purchasable={this.updatePurchaseState(this.props.ings)}
                        ordered={this.purchaseHandler}
                        Price={this.props.price} />
                </Aux>)
            orderSummary = <OrderSummary
                ingredients={this.props.ings}
                price={this.props.price}
                purchaseCanceled={this.purchaseCancelHandler}
                purchaseContinued={this.purchaseContinueHandler} />
        }
        if (this.state.loading) {
            orderSummary = <Spinner />
        }
        return (
            <Aux>
                <Modal show={this.state.purcahsing} modalClosed={this.purchaseCancelHandler}>
                    {orderSummary}
                </Modal>
                {burger}
            </Aux>
        )
    }
   
    updatePurchaseState(ingredients) {
        const sum = Object.keys(ingredients)
            .map(igKey => {
                return ingredients[igKey];
            })
            .reduce((sum, el) => {
                return sum + el;
            }, 0);
       return sum > 0 ;
    }
    purchaseHandler = () => {
        this.setState({ purcahsing: true })
    }
    purchaseCancelHandler = () => {
        this.setState({ purcahsing: false })
    }
    purchaseContinueHandler = () => {
        this.props.history.push('/checkout');
         
    }
}

const mapStateToProps = state=>{
    return{
        ings:state.ingredients,
        price:state.totalPrice
    };
}

const mapDispatchToProps= dispatch =>{
    return{
        onIngredientAdded: (ingName)=>dispatch({type:actionTypes.ADD_INGREDIENTS,ingredientName:ingName}),
        onIngredientRemoved: (ingName)=>dispatch({type:actionTypes.REMOVE_INGREDIENTS,ingredientName:ingName})
    }
}


export default connect(mapStateToProps,mapDispatchToProps)(withErrorHandler(BurgerBuilder, axios) );