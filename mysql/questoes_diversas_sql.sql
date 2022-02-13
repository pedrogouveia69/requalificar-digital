#66
select * from customers
where city like "san francisco";

#67
select avg(creditLimit) from customers
where city like "singapore";

#68
select * from payments
order by amount;

#70
select offices.officeCode, sum(payments.amount) receita from offices
inner join employees using(officeCode)
inner join customers on employees.employeeNumber = customers.salesRepEmployeeNumber
inner join payments using(customerNumber)
group by offices.officeCode
order by receita desc
limit 1;

#71
select offices.officeCode, count(*) clientes from offices
inner join employees using(officeCode)
inner join customers on employees.employeeNumber = customers.salesRepEmployeeNumber
group by employees.officeCode
order by clientes desc
limit 1;

#72
select * from customers 
where salesRepEmployeeNumber is null;

#73
#create table 2019419customers like customers;
#insert into 2019419customers select * from customers;
delete from 2019419customers
where salesRepEmployeeNumber is null;

#74
#Selecionar todas as encomendas que contêm 'Classic Cars'
select orders.orderNumber, products.productLine from orders
inner join orderdetails using (orderNumber)
inner join products on orderdetails.productCode = products.productCode
where products.productLine like "classic cars";

#77
select customerNumber, customers.country, offices.country from customers
inner join employees on customers.salesRepEmployeeNumber = employees.employeeNumber
inner join offices on employees.officeCode = offices.officeCode
where customers.country != offices.country;

#78
select customers.country, count(*) c from orders
inner join customers on orders.customerNumber = customers.customerNumber
group by country
order by c desc;

#79
select customers.customerNumber, count(*) c from employees
inner join customers on employees.employeeNumber = customers.salesRepEmployeeNumber
inner join orders using(customerNumber)
group by orders.customerNumber
order by c desc
limit 3;

#80
select c1.customerNumber, c1.contactLastName, c2.customerNumber, c2.contactLastName 
from customers c1, customers c2 
where c1.contactLastName = c2.contactLastName and c1.customerNumber != c2.customerNumber;