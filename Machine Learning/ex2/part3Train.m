
%vals is a 2x1 matrix
%part3([3;6],3,maindata,100,benchmarkdata,100);

function [threshold, w, accuracy] = part3Train(valuesArray, ...
                featureNo, trainData, noOfTrainExamples, noOfIterations)

[train, ~] = part3A(trainData, noOfTrainExamples, valuesArray);
feature = extractmyfeatures(reshape(train(1,:),16,16),featureNo);

noOfFeatures = size(feature,2);
noOfTrainingData = size(train,1);

trainingFeatures = zeros(noOfTrainingData,noOfFeatures);

for i=1:noOfTrainingData 
    trainingFeatures(i,:) = extractmyfeatures(reshape(...
                            train(i,:),16,16),featureNo);
end
                       


weightValues = double(randperm(1000))/1000;
w = weightValues(1:noOfFeatures);
for i = 1:noOfFeatures
    m = randperm(2);
    if m(1) == 1
        w(i) = -w(i);
    end
end
threshold = 1;
learningrate = 0.0001;

data = zeros(noOfTrainingData,noOfFeatures);

for i = 1:noOfTrainingData
data(i,:) = trainingFeatures(i,:);
end


%The first labels are 1 
%The second labels are 0
%for vals [3;8] ---> 3 -> 1, 8->0
target = [ones(noOfTrainExamples, 1);zeros(noOfTrainExamples,1)];
%predicted = zeros(noOfTestingData,1);
accuracy = zeros(noOfIterations,1);

%below is used for a while loop to make sure there are no errors
%numberOfErrors = 2;
%iteration =1;
%while numberOfErrors~=1
errorNo = zeros(noOfIterations);
disp('Initial Weights');
w
for iteration = 1:noOfIterations   
    errors = 0;
    for i = 1:noOfTrainingData
        
        active = 0;
        x = data(i,:);
        targ = target(i,:);
                
        for j = 1:noOfFeatures
            active = active + (w(j)*x(j));
        end
        
        if active > threshold
			output=1;
		else
			output=0;
        end
        
        for j = 1:noOfFeatures
            w(j) = w(j) + learningrate * (targ - output) * x(j);
        end
        
        %predicted(i,1) = output;
        threshold = threshold + learningrate * (targ-output) * -1;
        
        %disp(['prediction was: ' num2str(predicted(i,1))]);
        %disp(['target was: ' num2str(target(i,1))]);
        %disp(target(i,1));
        if output ~= targ
            errors = errors +1;
        end
        
       
    end
    errorNo(iteration) = errors;
    disp(['On Iteration ' num2str(iteration) ': There were ' ...
                  num2str(errors) ' Errors'])
    accuracy(iteration,1) = (noOfTrainingData - errors)/noOfTrainingData;
    disp(['End of iteration ' num2str(iteration) ]);
    
   %when using while loop to check when errors == 0
   %iteration = iteration + 1;
   %if errors == 0
   %     numberOfErrors = 1;
   % end
    
   %Below prints out eights and activations for each example
%{    
    text = char(['w(1)=' num2str(w(1))]);
    for j=2:noOfFeatures
        text=char(text,['w(' num2str(j) ')=' num2str(w(j))]);
    end  
    disp(text);
    
       
    activeMatrix = zeros(noOfTestingData);
    for i=1:noOfTestingData
        x = data(i,:);
        activeMatrix(i) = 0;
		for j = 1:noOfFeatures
            activeMatrix(i) = activeMatrix(i) + w(j)*x(j);
        end
       	disp(['Activation on example ' num2str(i) ' = ' ...
               num2str(activeMatrix(i)) ]);
    end
 %}
end
figure();
x = 1:1:noOfIterations;
y = accuracy(x,1);
%e = std(y)*ones(size(x));
%errorbar(x,y,e);
plot(x,y)
xlabel('Number of Iterations');
ylabel('Accuracy');
txt=char(['Accuracy of the perceptron for ' num2str(noOfTrainingData) ...
          ' examples of Training Data'], ... 
          ['             After ' num2str(noOfIterations) ' Iterations']);
title(txt);

figure();
x = 1:1:noOfIterations;
y = errorNo(x);
%e = std(y)*ones(size(x));
%errorbar(x,y,e);
plot(x,y)
xlabel('Number of Iterations');
ylabel('Errors');
txt=char(['Errors of the perceptron for ' num2str(noOfTrainingData) ...
          ' examples of Training Data'], ... 
          ['             After ' num2str(noOfIterations) ' Iterations']);
title(txt);






