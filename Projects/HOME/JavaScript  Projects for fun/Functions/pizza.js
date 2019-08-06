let orderCount = 0;

const takeOrder = (topping, crustType) => {
    console.log('Order: ' + crustType + ' pizza topped with '  + topping + ".");
    orderCount++
};
  
takeOrder('mushrooms', 'Thin crust');
takeOrder('cheese', 'Thin crust');
takeOrder('meat slices', 'Thin crust');

const getSubTotal = (itemCount) => {
    itemCount *= 7.5;
    return itemCount;
};

const getTax = (itemCount) => {
    return getSubTotal(itemCount) * 0.06;  //6% tax
};

const getTotal = (itemCount) => {
    return getTax(itemCount) + getSubTotal(itemCount);
};

console.log(getTotal(orderCount));