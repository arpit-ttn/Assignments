import React from 'react';
import classes from './SideDrawer.module.css';
import Logo from '../../Logo/Logo';
import NavigationItems from '../NavigationItems/NavigationItems';
import BackDrop from '../../UserInterface/BackDrop/BackDrop';
import Aux from '../../../hoc/Auxi';

const sideDrawer = (props) =>
{
	let attachedClasses =[classes.SideDrawer,classes.Close];
	if(props.open)
	{
		attachedClasses=[classes.SideDrawer,classes.Open];
	}
	return(
		<Aux>
		<BackDrop show={props.open} clicked={props.closed}/>
		<div className={attachedClasses.join(' ')}>
		<div className={classes.Logo}>
		 <Logo/>
		</div>
		<nav className={classes.DesktopOnly}>
		<NavigationItems/>
		</nav>
		</div>
		</Aux>
		)
}

export default sideDrawer;