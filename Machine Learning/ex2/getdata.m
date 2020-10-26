%first matrix gets 100 random samples of 3
%second matrix gets 200 random samples of 8
%firstT is the first matrix tranposed
%secondT is the second matrix transposed
%result is vertical concatination of the two transposed matrices

%test: [j,k] = getdata(maindata)
%reshape(j(1, :), 16,16) this gets the first row/sample and transforms
%k(101, :)
%the 1 by 256 matrix to a 16 by 16 matrix
function [result, labels] = getdata(maindata)
first = maindata(: , randi(500,100,1), 3);
second = maindata(: , randi(500,100,1), 8);
firstT = first';
secondT = second';
result = [firstT;secondT];
labels = [repmat(3, 100, 1);repmat(8,100,1)];




