%Matlab Coursework -- Lorenz Function
function ydot = mylorenz(rho, y)
ydot(1) = 10*(y(2) - y(1)); %(1a) with sigma = 10
ydot(2) = (rho*y(1)) - y(2) - (y(1)*y(3)); %(1b) with rho as an argument
ydot(3) = (y(1)*y(2)) - (8/3*y(3)); %(1c) with beta = 8/3
end



