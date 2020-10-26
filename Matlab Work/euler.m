function euler(rho)
%rho is an argument
y(1) = 0; 
y(2) = 1; 
y(3) = 0;
h = 0.001;  %h is the stepsize
t = [0:h:30];

for n=1:30000
   y(n+1,:) = y(n,:) + h*mylorenz(rho,y(n,:)); %uses mylorenz function
end;
y(30000,:) %outputs the last row's (30000) columns.
plot(t,y(:,1));
hold on
plot(t,y(:,2));
plot(t,y(:,3));
xlabel('Time (t)');
ylabel('Lorenz Equations'); 

%3d plot:
%plot3(y(:,1),y(:,2),y(:,3));
%xlabel('y1');
%ylabel('y2'); 
%zlabel('y3');








