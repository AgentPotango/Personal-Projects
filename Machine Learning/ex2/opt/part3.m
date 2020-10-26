
%vals is a 2x1 matrix
%part3([3;6],3,maindata,100,benchmarkdata,100);

function [accuracy] = part3(valuesArray, featureNo, trainData, noOfTrainExamples, ...
              testData, noOfTestExamples,noOfIterations)

[train, ~] = part3A(trainData, noOfTrainExamples, valuesArray);
[test, ~] = part3A(testData, noOfTestExamples, valuesArray);
feature = extractmyfeatures(reshape(test(1,:),16,16),featureNo);

noOfFeatures = size(feature,2);
noOfTrainingData = size(train,1);
noOfTestingData = size(test,1);

trainingFeatures = zeros(noOfTrainingData,noOfFeatures);
testingFeatures = zeros(noOfTestingData,noOfFeatures);

for i=1:noOfTrainingData 
    trainingFeatures(i,:) = extractmyfeatures(reshape(...
                            train(i,:),16,16),featureNo);
end

for i=1:noOfTestingData
    testingFeatures(i,:) = extractmyfeatures(reshape(...
                            test(i,:),16,16),featureNo);
end                            



weightValues = double(randperm(1000))/1000;
w = weightValues(1:noOfFeatures);
threshold = 900;
learningrate = 0.1;

data = zeros(noOfTrainingData,noOfFeatures);

for i = 1:noOfTestingData
data(i,:) = testingFeatures(i,:);
end


%The first labels are 1 
%The second labels are 0
%for vals [3;8] ---> 3 -> 1, 8->0
target = [ones(noOfTestExamples, 1);zeros(noOfTestExamples,1)];
%predicted = zeros(noOfTestingData,1);
accuracy = zeros(noOfIterations,1);

%numberOfErrors = 2;
%iteration =1;

%while numberOfErrors~=1

for iteration = 1:noOfIterations   
    errors = 0;
    for i = 1:noOfTestingData
        
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
        if output ~= target(i,1)
            errors = errors +1;
        end
        
       
    end
    disp(['On Iteration ' num2str(iteration) ': There were ' ...
                  num2str(errors) ' Errors'])
    accuracy(iteration,1) = (noOfTestingData - errors)/noOfTestingData;
    disp(['End of iteration ' num2str(iteration) ]);
   %iteration = iteration + 1;
   %if errors == 0
   %     numberOfErrors = 1;
   % end
    
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


